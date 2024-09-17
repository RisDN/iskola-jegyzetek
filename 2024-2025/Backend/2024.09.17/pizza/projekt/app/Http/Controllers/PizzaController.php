<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\PizzaModel;

class PizzaController extends Controller
{
    public function welcome() {

        return view('allpizzas', [
            'result' => PizzaModel::all()
        ]);
    }

    public function random() {
        return view('random', [
            'result' => PizzaModel::inRandomOrder()->first()
        ]);
    }

    public function akcios() {
        return view('akcios', [
            'result' => PizzaModel::where('akcios', 1)->get()
        ]);
    }
}
