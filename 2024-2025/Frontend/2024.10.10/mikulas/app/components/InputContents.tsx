
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
                <div className="flex flex-col mt-9">
                    <span>Ennek fényében mit szeretnél karácsonyra?</span>
                    <textarea className="w-full h-24" name="" id="present"></textarea>
                </div>
            </div>
            <div>
                <Title text="Frissítőkről szoló rész" />
                <span className="text-md font-bold">Ki lesz készítve némi frissítő?</span>
                <div className="flex flex-col">
                    <label>
                        <input type="radio" defaultChecked className="mr-2" name="wasgood" value="frissito" />
                        Igen
                    </label>
                </div>
                <span className="font-bold">Milyen típusú frissítők lesznek kikészítve? <span className="font-normal italic">(Kérlek, egynél mindenképpen többet jelölj be)</span></span>
                <div className="flex flex-col mt-5">
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="brandy" />
                        Brandy
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="rum" />
                        Rum
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="gin" />
                        Gin
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="scotch" />
                        Scotch
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="vodka" />
                        Vodka
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="palinka" />
                        Pálinka
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="sor" />
                        Sör
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="bor" />
                        Bor
                    </label>
                    <label>
                        <input type="checkbox" className="mr-2" name="place" value="martini" />
                        Martini
                    </label>
                </div>
            </div>
            <div>
                <Title text="Hozzáférési adatok" />
                <span className="mt-5 text-md font-bold">Mi a tetőtök lejtésszöge?</span>
                <div className="flex flex-row">
                    <input className="w-24" type="number" /> <span className="ml-2">fok</span>
                </div>
                <span>Ha a tető lejtése eléri/meghaladja a 30 fokot, akkor kérlek, csatolj egy vázlatrajzot a tetőről, feltüntetve legalább kettő (2) rögzítési pontot <span className="italic">(pl. TV antenna, szellőző, kémény, stb.)</span></span>
                <input type="file" />

                <div className="flex flex-col my-5">
                    <span className="text-md font-bold">A tetőtök képes elviselni legalább 1 tonna tömeget négyzetméterenként? <span className="font-normal italic">(9 rénszarvas, komplett szán, meg egy túlméretes pali furi ruhában)</span></span>
                </div>

                <div className="flex flex-col align-middle gap-1">
                    <label>
                        <input name="roof" className="mr-2" type="radio" />
                        Igen
                    </label>
                    <label>
                        <input name="roof" className="mr-2" type="radio" />
                        Nem / Ebben az esetben az autóbehajtón egyetlen macskánál nagyobb tárgy sem maradhat.
                    </label>
                    <label>
                        <input name="roof" className="mr-2" type="radio" />
                        Talán / Ebben az esetben kérlek, csatolj egy regisztrált tervező által kiállított nyilatkozatot a tető átlagos teherbírásáról.
                    </label>
                </div>
                <span className="my-5 font-bold text-md">Van kéményetek?</span>
                <div className="flex flex-col align-middle gap-1">
                    <label>
                        <input name="kemeny" className="mr-2" type="radio" />
                        Van / Ebben az esetben mindenképpen ellenőrizd, hogy tűztér mentes minden parázsló és éles tárgytól.
                        A légjárat becsült átlagos átmérője <input className="w-24" type="number" /> centiméter.
                        <div className="flex flex-col">
                            Mikor volt sepertetve? <input className="w-28" type="date" />
                        </div>
                    </label>
                    <label>
                        <input name="kemeny" className="mr-2" type="radio" />

                    </label>
                    <label>
                        <input name="kemeny" className="mr-2" type="radio" />
                        Talán / Ebben az esetben kérlek, csatolj egy regisztrált tervező által kiállított nyilatkozatot a tető átlagos teherbírásáról.
                    </label>
                </div>
            </div>

            <div>
                <span>És még?</span>
                <textarea className="w-full h-24 mt-5" name="" id=""></textarea>
            </div>
        </div>
    );
};


export default InputContents;