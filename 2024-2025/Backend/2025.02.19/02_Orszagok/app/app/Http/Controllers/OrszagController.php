<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Models\KontinensModel;
use App\Models\OrszagModel;

class OrszagController extends Controller
{
    public function GetOrszagById($id) {
        return view("orszag", [
            "kontinens" => KontinensModel::where("kontinens_id", "=", $id),
            "result" => OrszagModel::orderBy("nev")->where("kontinens_id", "=", $id)->get(),
            "kontinensek" => KontinensModel::all(),
        ]);
    }
}
