<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\SzaloncukorModel;

class SzaloncukorController extends Controller
{
    public function welcome()
    {
        $szaloncukor = SzaloncukorModel::all();
        return view('welcome', ['results' => $szaloncukor]);
    }

    public function add(Request $request)
    {

        $request->validate([
            'suly' => 'required|numeric|min:100',
            'iz' => 'required',
            'marka' => 'required',
            'ar' => 'required|numeric|min:100',
        ], [
            'iz.required' => 'Az íz megadása kötelező!',
            'marka.required' => 'A márka megadása kötelező!',
            'ar.required' => 'Az ár megadása kötelező!',
            'ar.numeric' => 'Az ár csak szám lehet!',
            'ar.min' => 'Minimum ár 100 Ft!',
            'suly.required' => 'A súly megadása kötelező!',
            'suly.numeric' => 'A súly csak szám lehet!',
            'suly.min' => 'Minimum súly 100 gramm!',
        ]);

        $szaloncukor = new SzaloncukorModel;

        $szaloncukor->marka = $request->marka;
        $szaloncukor->iz = $request->iz;
        $szaloncukor->suly = $request->suly;
        $szaloncukor->ar = $request->ar;
        $szaloncukor->plusz18 = $request->plusz18 == 'on' ? 1 : 0;;

        $szaloncukor-> Save();

        return redirect('/');
    }

}
