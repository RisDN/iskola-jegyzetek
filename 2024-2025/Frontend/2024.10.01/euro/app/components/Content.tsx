import Image from "next/image";

export interface ContentProps {
    title: string;
    description: string;
    imageUrl?: string;
}

const Content = (props: ContentProps) => {
    return (
        <div className="mt-5 p-5 rounded-sm bg-yellow-100 border-green-800 border-[1px] border-r-green-800 border-l-green-800 border-r-4 border-l-4">
           <div className="bg-gray-200 border-[1px] rounded-sm border-green-800">
                <div className="w-full border-b-[1px] border-b-gray-400 p-5">
                    <h1 className="uppercase text-green-800 font-bold text-lg">{props.title}</h1>
                </div>
                {props.imageUrl && 
                    <Image src={`/imgs/${props.imageUrl}`} alt={props.imageUrl}  width={0}
                    height={0}
                    sizes="100vw"
                    style={{ width: '100%', height: 'auto' }} />
                }

                <div className="leading-8 p-5 h-full">
                    {props.description}
                </div>  

                <div className="flex justify-end align-middle items-center">
                    <button className="bg-green-700 p-2 m-5 rounded-lg text-sm text-white">Ugrás az oldal tetejére</button>
                </div>

           </div>
        </div>
    );
};


export default Content;