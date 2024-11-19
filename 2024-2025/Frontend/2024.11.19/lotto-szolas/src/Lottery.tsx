import { useEffect, useState } from "react";


function Lottery() {

    const [currentLastNumber, setCurrentLastNumber] = useState<number>(0);
    const [gridCols, setGridCols] = useState<number>(0);

    useEffect(() => {
        document.addEventListener('keydown', (event) => {
            switch (event.key) {
                case '5':
                    setCurrentLastNumber(90);
                    setGridCols(10);
                    break;
                case '6':
                    setCurrentLastNumber(45);
                    setGridCols(7);
                    break;
                case '7':
                    setCurrentLastNumber(35);
                    setGridCols(5);
                    break;
            }
        });
    }, []);

    const numbers = () => {
        return Array.from({ length: currentLastNumber }, (_, i) => i + 1);
    };

    const getGridClassname = () => {
        let width;

        switch (gridCols) {
            case 10:
                width = 'w-1/6';
                break;
            case 7:
                width = 'w-1/10';
                break;
            case 5:
                width = 'w-1/12';
                break;
        }

        return width + ' gap-1 gap-x-5 grid grid-cols-' + gridCols;
    };

    return (
        <>
            <div className="text-center p-5 w-full bg-slate-100 flex flex-col">
                <span className="text-3xl">Lottó</span>
                <div>
                    <span className={currentLastNumber === 90 ? "text-green-500 font-bold" : ""}>5: ötös lottó, </span>
                    <span className={currentLastNumber === 45 ? "text-green-500 font-bold" : ""}>6: hatos lottó, </span>
                    <span className={currentLastNumber === 35 ? "text-green-500 font-bold" : ""}>7: skandináv lottó </span>
                </div>
            </div>
            <div className="flex justify-center m-5">
                <div className={getGridClassname()}>
                    {numbers().map((number) => (
                        <div className="w-8 h-8 text-center border-red-600 border-2">{number}</div>
                    ))}
                </div>
            </div >
        </>
    );
}

export default Lottery;