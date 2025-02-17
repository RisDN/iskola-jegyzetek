<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\BolygoController;

Route::get('/', function () {
    return view('welcome');
});


Route::get('/bolygok/{id}', [BolygoController::class, "bolygoById"]);
