<?php

namespace App\Http\Controllers;

use App\Models\AlapanyagokModel;
use App\Models\EtelekModel;
use App\Models\HozzavalokModel;
use Illuminate\Http\Request;

class EtelekController extends Controller
{
    public function All() {

        $data = [
            "etelek" => EtelekModel::all(),
        ];

        return view('welcome', $data);
    }

    public function EtelById($id) {

        $data = [
            "etel" => EtelekModel::where('etelid', '=', $id)->get(),
            "alapanyagok" => AlapanyagokModel::join('hozzavalok', 'hozzavalok.anyagid', '=', 'alapanyagok.anyagid')->select('alapanyagok.*', 'hozzavalok.*')->where('hozzavalok.etelid', '=', $id)->distinct()->get()
        ];

        return view('etel', $data);

    }
}
