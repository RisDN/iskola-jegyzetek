<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\DB;
use Illuminate\Http\Request;
use App\Models\KontinensModel;
use App\Models\OrszagModel;

class KontinensController extends Controller
{
    public function GetKontinensById($id) {

        return view('kontinens', [
            "result" => KontinensModel::all()->where("kontinens_id", "=", $id)->first(),
            "darabszam" => count(OrszagModel::all()->where("kontinens_id", "=", $id)),
            "kontinensek" => KontinensModel::all(),
        ]);

    }
}
