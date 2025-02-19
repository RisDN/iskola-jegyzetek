<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\KontinensController;
use App\Http\Controllers\OrszagController;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/kontinensek/{id}', [KontinensController::class, 'GetKontinensById']);


Route::get('/orszagok/{id}', [OrszagController::class, 'GetOrszagById']);
