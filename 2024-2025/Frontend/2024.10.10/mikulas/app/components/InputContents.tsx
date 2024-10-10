
import Title from "./Title";

const InputContents = () => {
    return (
        <div className="grid grid-cols-2 w-full px-6 gap-10">
            <div>
                <Title text="A jelentkező adatai" />
                <div className="flex flex-col">
                    <span>Milyen neveket adtak neked a szüleid?</span>
                    <input className="" type="text" />
                    <span>Hol élsz?</span>
                    <input className="" type="text" />
                </div>
            </div>
            <div >
                <Title text="Ajándék-elhelyezés részletei" />
                <span>Hol szeretnéd megtalálni a meglepetést?</span>

                <div className="flex flex-col align-middle gap-1">
                    <label>
                        <input className="mr-2" type="radio" name="place" value="fa" />
                        Lábbeliben <span className="italic">(Kérlek add meg a méretét)</span> <input type="number" />
                    </label>
                    <label>
                        <input className="mr-2" type="radio" name="place" value="kandallo" />
                        Ágy végében
                    </label>
                    <label>
                        <input className="mr-2" type="radio" name="place" value="ablak" />
                        Karácsonyfa alatt
                    </label>
                    <label>
                        <input className="mr-2" type="radio" name="place" value="ablak" />
                        Elrejtve / Ebben az esetben állítsd be a megtalálási nehézséget
                        <div className="w-full py-2">
                            <div className="float-left">Azonnal legyen meg</div>
                            <input className="w-full" type="range" min="0" max="10" />
                            <div className="float-right">Rámehet az egész nap</div>
                        </div>
                    </label>

                </div>
            </div>

            <div>
                <Title text="Jó voltál?" />
                <span>Kérlek, jelöld be az elmúlt 12 havi magaviseletednek a megfelelő értékét. <span className="text-red-600">Ne feledd! A mikulás előtt nincs titok.</span></span>
                <div className="w-full py-2">
                    <div className="float-left">Angyali</div>
                    <input className="w-full" type="range" min="0" max="10" />
                    <div className="float-right">Vásott</div>
                </div>
            </div>
            <div>
                <Title text="Frissítőkről szoló rész" />
                <span className="text-md font-bold">Ki lesz készítve némi frissítő?</span>
                <div className="flex flex-col">
                    <label>
                        <input type="radio" className="mr-2" name="place" value="frissito" />
                        Igen
                    </label>
                </div>
            </div>
        </div>
    );
};


export default InputContents;