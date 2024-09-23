<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PizzaController;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/all', [PizzaController::class, 'welcome']);
Route::get('/rnd', [PizzaController::class, 'random']);
Route::get('/akciosok', [PizzaController::class, 'akcios']);
Route::get('/adatlap/{id}', [PizzaController::class, 'adatlap']);
