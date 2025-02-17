import Image from "next/image";
import { Csillagjegy } from "../providers/CsillagjegyProvider";

const months = [
    "Január",
    "Február",
    "Március",
    "Április",
    "Május",
    "Június",
    "Július",
    "Augusztus",
    "Szeptember",
    "Október",
    "November",
    "December"
]
const CsillagjegyCard = ({
    jegy,
    kho,
    knap,
    vho,
    vnap,
    elem,
    minoseg,
    kulcsszavak,
    mozgas,
    kep,
    jel,
}: Csillagjegy) => {


    const startMonth = months[parseInt(kho) - 1];
    const endMonth = months[parseInt(vho) - 1];

    return (
        <div className="bg-gradient-to-r mt-96 sm:mt-0 mb-5 from-slate-300 via-slate-400 to-slate-300 p-6 rounded-lg shadow-2xl drop-shadow-2xl w-full sm:w-1/2">
            <div className="flex justify-between items-center align-middle gap-5">
                <h1 className="text-center text-4xl font-bold text-slate-600 drop-shadow-lg mb-4">{jegy}</h1>
                <Image width={50} height={50} src={jel} alt={jegy} />
            </div>
            <div className="flex justify-center mb-4">
                <Image className="rounded-full border-4 border-white shadow-lg" width={256} height={256} src={kep} alt={jegy} />
            </div>
            <p className="my-2">{startMonth} {knap}. - {endMonth} {vnap}.</p>
            <ul className="text-slate-500 text-lg">
                <li><strong>Elem:</strong> {elem}</li>
                <li><strong>Minőség:</strong> {minoseg}</li>
                <li><strong>Kulcsszavak:</strong> {kulcsszavak}</li>
                <li><strong>Mozgás:</strong> {mozgas}</li>
            </ul>
        </div>
    );
};

export default CsillagjegyCard;