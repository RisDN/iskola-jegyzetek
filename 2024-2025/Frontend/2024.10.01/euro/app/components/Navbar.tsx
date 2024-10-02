import React from "react";
const Navbar = () => {
    return (
        <>
            <div className="nav-img h-96 w-full flex justify-center items-center align-middle bg-slate-400">
                <span className="mb-52 text-5xl text-green-800 font-bold">EURO</span>
            </div>
            <div className="mt-5 flex gap-12 justify-center align-middle items-center text-green-800">
             <a href="">Az Euro</a>
             <a href="">Gazdasági erőssége</a>
             <a href="">Az Euro mint fizetőeszköz</a>
             <a href="">Bevezetésének közvetlen előzményei</a>
            </div>
        </>
    );
};


export default Navbar;