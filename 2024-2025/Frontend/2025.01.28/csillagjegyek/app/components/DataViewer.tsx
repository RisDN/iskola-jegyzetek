"use client";

import { useCsillagjegyProvider } from "../providers/CsillagjegyProvider";
import CsillagjegyCard from "./CsillagjegyCard";

const DataViewer = () => {

    const { data, selectedJegy, getSelectedJegy } = useCsillagjegyProvider();

    return (
        <div className="flex justify-center items-center align-middle w-full h-screen text-3xl">

            {!selectedJegy && (
                <h1 className="text-red-600 text-center">Válasszon ki fentről egy csillagjegyet.</h1>
            )}

            {selectedJegy && data &&
                (
                    <CsillagjegyCard {...getSelectedJegy(selectedJegy)} />
                )
            }


        </div>
    );
};


export default DataViewer;