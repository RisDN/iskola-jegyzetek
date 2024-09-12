<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\EledelModel;

class EledelController extends Controller
{
    public function welcome() {

        return view('eledel', [
            'result' => EledelModel::all()
        ]);
    }
}
