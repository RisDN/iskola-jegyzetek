<?php

namespace App\Http\Controllers;

use App\Models\EtelekModel;
use Illuminate\Http\Request;

class KeresesController extends Controller
{
    public function KeresesView() {
        return view('kereses');
    }

    public function Kereses(Request $request) {

        $request->validate([
            'search' => 'required|min:4'
        ], [
            'search.required' => "Adjon meg valami keresendőt!",
            'search.min' => "Legalább 4 karaktert adjon meg!"
        ]);

        $search = '%' . $request->search . '%';
        $data = [
            'data' => EtelekModel::where('nev', 'LIKE', $search)->get()
        ];

        return view('kereses', $data);

    }

}
