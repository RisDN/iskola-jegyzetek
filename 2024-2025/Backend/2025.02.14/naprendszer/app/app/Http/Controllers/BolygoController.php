<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\BolygoModel;

class BolygoController extends Controller
{
    public function bolygoById($id) {

        return view('bolygo', [
            "bolgyok" => BolygoModel::all("nev", "bolygok_id"),
            "result" => BolygoModel::all()->where("bolygok_id", "=", $id)->first()
        ]);
    }
}
