<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\LottoModel;

class LottoController extends Controller
{
    public function welcome() {
        return view('welcome', [
            'result' => LottoModel::distinct()->get(['ev']),
        ]);
    }
}
