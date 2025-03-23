<?php

namespace App\Http\Controllers;

use App\Models\JaratModel;
use App\Models\MegalloModel;

class MegalloController extends Controller
{
    public function GetMegalloById($id) {

        $data = [
            "megallo" => MegalloModel::where('megallo_id', '=', $id)->get(),
            "jaratok" => JaratModel::join('utvonal', 'jaratok.jaratok_id', '=', 'utvonal.jarat_id')->select('utvonal.*', 'jaratok.*')->where('utvonal.megallo_id', '=', $id)->where('utvonal.utirany', '=', 'o')->distinct()->get()
        ];

        return view("megallo", $data);

    }
}
