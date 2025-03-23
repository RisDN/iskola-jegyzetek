<?php

use App\Http\Controllers\JaratController;
use App\Http\Controllers\KeresesController;
use App\Http\Controllers\MegalloController;
use Illuminate\Support\Facades\Route;

Route::get('/', [JaratController::class, 'Welcome']);

Route::get('/jarat/{id}', [JaratController::class, 'GetJaratById']);
Route::get('/jaratok', [JaratController::class, 'GetJaratok']);

Route::get('/megallo/{id}', [MegalloController::class, 'GetMegalloById']);

Route::get('/kereses', [KeresesController::class, 'KeresesView']);
Route::post('/kereses', [KeresesController::class, 'Kereses']);
