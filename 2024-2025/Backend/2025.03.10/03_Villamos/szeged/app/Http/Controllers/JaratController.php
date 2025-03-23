<?php

namespace App\Http\Controllers;

use App\Models\JaratModel;
use App\Models\MegalloModel;
use Illuminate\Http\Request;

class JaratController extends Controller
{
    public function Welcome() {

        $data = [
            "jaratok" => JaratModel::all()
        ];

        return view('welcome', $data);
    }

    public function GetJaratok() {

        $data = [
            "jaratok" => JaratModel::all()
        ];

        return view('jaratok', $data);

    }

    public function GetJaratById($id) {

        $data = [
            "jarat" => JaratModel::select('*')->where("jaratok_id", '=', $id)->get(),
            "megallok" => MegalloModel::join('utvonal', 'megallo.megallo_id', '=', 'utvonal.megallo_id')->select('megallo.*', 'utvonal.*')->where("utvonal.jarat_id", "=", $id)->distinct()->get()
        ];

        return view('jarat', $data);

    }
}
