<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\KontinensModel;

class KontinensController extends Controller
{
    public function GetKontinensById($id) {
        return view('kontinens', [
            "result" => KontinensModel::all()->where("kontinens_id", "=", $id)->first(),
        ]);
    }
}
