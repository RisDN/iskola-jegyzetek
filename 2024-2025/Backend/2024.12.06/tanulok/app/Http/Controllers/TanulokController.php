<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\tanulok;

class TanulokController extends Controller
{
    public function Tanulok(){
        return view('welcome', [
            'result'    => tanulok::all(),
            'agazat'    => ['Elektronika és elektrotechnika', 'Informatika és távközlés', 'Rendészet és közszolgálat']
        ]);
    }

    public function TanulokData(){

    }
}
