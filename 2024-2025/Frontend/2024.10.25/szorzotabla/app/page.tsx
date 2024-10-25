"use client";
import Image from "next/image";
import { useEffect, useRef, useState } from "react";

interface SzorzotablaProps {
  result: number;
  calculation: string;
}

const isPrimeNumber = (input: number) => {

  if (input <= 1) {
    return false;
  }

  for (let i = 2; i < input; i++) {
    if (input % i === 0) {
      return false;
    }
  }

  return true;

};

export default function Home() {

  const [numbers, setNumbers] = useState<SzorzotablaProps[][]>([]);
  const inputRef = useRef<HTMLInputElement>(null);

  const calculate = () => {
    const number = parseInt(inputRef.current?.value || '');
    if (isNaN(number)) {
      setNumbers([]);
      return;
    }

    const table = [];

    for (let i = 0; i <= number; i++) {
      const row = [];
      for (let j = 0; j <= 10; j++) {
        if (i === 0) {
          row.push({ result: j, calculation: `${i} * ${j}` });
        } else if (j === 0) {
          row.push({ result: i, calculation: `${i} * ${j}` });
        } else {
          row.push({ result: i * j, calculation: `${i} * ${j}` });
        }
      }
      table.push(row);
    }

    setNumbers(table);
  };

  return (
    <div className="flex justify-center items-center flex-col">
      <h1 className="text-center">Szorzótábla</h1>

      <input type="number" className="border-2 border-gray-600 my-5 rounded-lg p-1" onChange={() => calculate()} ref={inputRef} placeholder="pl.: 2" />

      <table className="border-2 border-gray-600 w-1/2">
        <tbody>
          {numbers.map((row, i) => (
            <tr key={i} className={i === 0 ? "bg-red-300" : ""} title={row[i].calculation}>
              {row.map((cell, j) => (
                <td key={j} className={`border-2 border-gray-600 p-2 text-center w-8 h-8 ${isPrimeNumber(cell.result) && j !== 0 ? 'bg-red-600' : ''} ${j === 0 ? "bg-red-300" : ""}`}>
                  {cell.result}
                </td>
              ))}
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}