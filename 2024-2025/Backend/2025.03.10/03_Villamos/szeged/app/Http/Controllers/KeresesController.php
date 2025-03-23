<?php

namespace App\Http\Controllers;

use App\Models\MegalloModel;
use Illuminate\Http\Request;

class KeresesController extends Controller
{
    public function KeresesView() {
        return view('kereses');
    }

    public function Kereses(Request $request) {

        $request->validate([
            'search' => 'required|min:4',
        ], [
            'search.required' => 'Legalább 4 karaktert adj meg!',
            'search.min' => 'Legalább 4 karaktert adj meg!'
        ]);


        $search = MegalloModel::where('nev', 'LIKE', '%'. $request->search .'%')->get();

        return view('kereses', [
            "search" => $search
        ]);

    }
}
