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

    public function otos() {
        return view('otos', [
            'result' => LottoModel::where('talalat5_db', '>', 0)->get(),
        ]);
    }

    public function ev($ev) {
        return view('ev', [
            'result' => LottoModel::where('ev', $ev)->get(),
        ]);
    }

    public function adatlap($ev, $het) {
        return view('adatlap', [
            'result' => LottoModel::where('ev', $ev)->where('het', $het)->get(),
        ]);
    }
}
