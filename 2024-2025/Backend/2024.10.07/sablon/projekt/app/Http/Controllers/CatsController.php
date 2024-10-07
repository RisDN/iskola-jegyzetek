<?php

namespace App\Http\Controllers;

use App\Models\CatsModel;

class CatsController extends Controller
{


    public function pics()
    {
        $images = CatsModel::all();
        return view('cats', ['result' => $images]);
    }

}
