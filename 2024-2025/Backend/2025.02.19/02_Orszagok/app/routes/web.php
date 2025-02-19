<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\KontinensController;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/kontinensek/{id}', [KontinensController::class, 'GetKontinensById']);
