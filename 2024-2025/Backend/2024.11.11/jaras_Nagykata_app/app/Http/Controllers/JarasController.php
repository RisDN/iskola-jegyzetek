<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Telepulesek;

class JarasController extends Controller
{

    public function welcome() {
        return view('welcome');
    }

    public function telepulesek() {
        return view('telepulesek', [
            'result' => Telepulesek::orderBy("nev")->get()
        ]);
    }

    public function adatlap($id) {
        return view('adatlap', [
            'result' => Telepulesek::where('id', $id)->get()
        ]);
    }
}
