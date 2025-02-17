"use client";
import { Context, createContext, useContext, useEffect, useState } from "react";


const api_url = "https://info.nytta.hu/web/api/csillagjegyek/";

export interface Csillagjegy {
    jegy: string;
    kho: string;
    knap: string;
    vho: string;
    vnap: string;
    elem: string;
    minoseg: string;
    kulcsszavak: string;
    mozgas: string;
    kep: string;
    jel: string;
}

interface CsillagjegyProviderProps {
    data: Csillagjegy[] | undefined;
    selectedJegy: string | undefined;
    setSelectedJegy: (jegy: string) => void;
    getSelectedJegy: (jegy: string) => Csillagjegy;
};

const CsillagjegyProviderCtx = createContext<CsillagjegyProviderProps | undefined>(undefined);

export const CsillagjegyProvider = ({ children }: { children: React.ReactNode }) => {

    const [data, setData] = useState<Csillagjegy[]>();
    const [selectedJegy, setSelectedJegy] = useState<string>();

    const getSelectedJegy = (jegy: string): Csillagjegy => {
        return data!.find(csillagjegy => csillagjegy.jegy === jegy)!;
    };

    useEffect(() => {

        fetch(api_url)
            .then(response => response.json())
            .then(data => {
                setData(data);
                console.log(data)
            })
            .catch(err => {
                console.error(err);
            }
            );

    }, [])


    return (
        <CsillagjegyProviderCtx.Provider value={{
            data,
            selectedJegy,
            setSelectedJegy,
            getSelectedJegy
        }}>
            {children}
        </CsillagjegyProviderCtx.Provider>
    );
};


export const useCsillagjegyProvider = () => useContext<CsillagjegyProviderProps>(CsillagjegyProviderCtx as Context<CsillagjegyProviderProps>);