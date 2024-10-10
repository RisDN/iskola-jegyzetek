const BUTTON_STYLES = "h-10 rounded-xl text-[13px] px-2 text-center p-2 border-gray-400 border-b-[2px] border-r-[2px] border-l-[0.5px] border-t-[0.5px]";

const ControlButtons = () => {
    return (
        <div className="flex justify-end align-middle items-center gap-2 p-5">
            <button className={`${BUTTON_STYLES} text-red-700`}>Újrakezdem</button>
            <button className={`${BUTTON_STYLES} text-white bg-red-800`}>Benyújtom a kérelmet</button>
        </div>
    );
};


export default ControlButtons;