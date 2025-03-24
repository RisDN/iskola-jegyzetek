<?php

use App\Http\Controllers\EtelekController;
use App\Http\Controllers\KeresesController;
use Illuminate\Support\Facades\Route;

Route::get('/', [EtelekController::class, 'All']);
Route::get('/etel/{id}', [EtelekController::class, 'EtelById']);


Route::get('/kereses', [KeresesController::class, 'KeresesView']);
Route::post('/kereses', [KeresesController::class, 'Kereses']);
