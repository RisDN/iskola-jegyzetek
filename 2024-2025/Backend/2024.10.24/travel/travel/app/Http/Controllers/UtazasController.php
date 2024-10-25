<?php

namespace App\Http\Controllers;

use App\Models\UtazasModel;

class UtazasController extends Controller
{
    public function welcome() {
        return view('welcome', [
            'result' => UtazasModel::all(),
        ]);
    }

    public function utazas($id) {
        return view('utazas', [
            'result' => UtazasModel::find($id),
        ]);
    }

    public function uticel($uticel) {
        return view('uticel', [
            'result' => UtazasModel::where('uticel', $uticel)->get(),
            'uticel' => $uticel,
        ]);
    }
}
