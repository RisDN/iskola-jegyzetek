
import React from 'react';
import Header from './components/Header';
import TextContent from './components/TextContent';
import Footer from './components/Footer';
import ControlButtons from './components/ControlButtons';

export default function Home() {
	return (
		<div className='border-2 border-red-900 bg-gray-100'>
			<Header />
			<TextContent title='Bevezető' text='Nagy pelyhekben hull a hó, mindjárt itt a Mikulás. Persze rengeteg dolga van és minden gyerek egyformán fontos neki, ezért segítségre van szüksége. Az ajándékigények feldolgozásának elősegítésére kérlek, teljesen őszintén töltsd ki az alábbi űrlapot! <span class="text-red-600">Ne feledd! A Mikulás előtt nincs titok.</span>' />
			<TextContent title='Nyilatkozat' text='Én, a fentiekben megadott nevű és a fentebb jelzett címen lakó gyermek ezennel kijelentem, hogy az itt megadott adatok minden részletükben igazak. Ezen túlmenően felhatalmazom a Mikulást, hogy az adatok igazolása érdekében felvegye a kapcsolatot a szüleimmel. Kinyilvánítom annak megértését, hogy az általuk és az általam közöltek esetleges eltérése esetén <span class="italic">(főleg magaviselet témájában)</span>, ez egy sovány Karácsony lesz... Ígérem, hogy a Mikulás megérkezésekor aludni fogok, mert előtte nincs titok.' />
			<ControlButtons />
			<Footer />
		</div>
	);
}
