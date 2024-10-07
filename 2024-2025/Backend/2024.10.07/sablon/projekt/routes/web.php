<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\CatsController;

Route::get('/', function () {
    return view('welcome');
});


Route::get('/pics', [CatsController::class, 'pics']);
