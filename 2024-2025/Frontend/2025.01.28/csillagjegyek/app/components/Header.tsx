"use client";

import { useCsillagjegyProvider } from "../providers/CsillagjegyProvider";

const Header = () => {

    const { data, selectedJegy, setSelectedJegy } = useCsillagjegyProvider();

    return (
        <header className="w-full flex flex-col sm:flex-row justify-between bg-slate-500 rounded-bl-lg rounded-br-lg drop-shadow-2xl h-auto border-">
            {data && data.map((csillagjegy, index) => (
                <div onClick={() => setSelectedJegy(csillagjegy.jegy)} key={index} className={`flex m-3 justify-center items-center ${selectedJegy === csillagjegy.jegy ? "text-green-500" : "text-gray-200"}`}>
                    <h1 className="text-2xl cursor-pointer hover:scale-110 transition-all drop-shadow-2xl shadow-2xl">{csillagjegy.jegy}</h1>
                </div>
            ))}
        </header>
    );
};


export default Header;