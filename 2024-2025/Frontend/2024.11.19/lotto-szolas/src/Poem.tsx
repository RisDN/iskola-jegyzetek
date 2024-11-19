import { useEffect, useState } from "react";
import data from "./data.json";

function Poem() {
    const getRandomItem = () => {
        const randomIndex = Math.floor(Math.random() * data.data.length);
        setItem(data.data[randomIndex]);
        setIsLiked(false);
    };

    const liked = () => {
        setIsLiked(true);
    };

    const [item, setItem] = useState<string>();
    const [isLiked, setIsLiked] = useState<boolean>(false);

    useEffect(() => {
        getRandomItem();
    }, []);

    return (
        <>
            <div className='text-center text-3xl p-5 w-full bg-slate-100'>{isLiked && "❤"} {item}</div>

            <div className="flex justify-center items-center align-middle text-center gap-2 p-5">
                <button
                    className='bg-red-500 hover:bg-red-700 text-white font-bold py-2 px-4 rounded'
                    onClick={getRandomItem}>Ez nem tetszik!
                </button>

                <button
                    className='bg-green-500 hover:bg-green-700 text-white font-bold py-2 px-4 rounded'
                    onClick={liked}>Ez tetszik
                </button>

            </div>
        </>
    );
}

export default Poem;