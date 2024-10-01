import React from "react";
const Footer = () => {
    return (
        <>
            <div className="italic flex justify-center items-center align-middle">
                Szövegek forrása: <a className="not-italic text-green-800" href="https://wikipedia.com">Wikipédia</a>
            </div>
            <div className="italic flex justify-center items-center align-middle">
                Képek forrása: <a className="not-italic text-green-800" href="https://unsplash.com">Unsplash</a>
            </div>
        </>
    );
};


export default Footer;