import Image from "next/image";

const Header = () => {
    return (
        <header className="w-full h-64 bg-red-700">
            <div className="h-[70%]">
                <Image width={740} height={295} className="object-fit w-full h-full" alt="Mikulás Banner" src={"/imgs/banner.jpg"} />
            </div>
            <div className="h-[30%] bg-red-800 border-t-[3px] border-t-red-600 border-b-[2.5px] border-b-red-600 flex justify-center align-middle items-center">
                <h1 className=" text-white uppercase font-bold">Mikulás látogatási kérelem</h1>
            </div>

        </header>
    );
};


export default Header;