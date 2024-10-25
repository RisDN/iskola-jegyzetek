<?php

use App\Http\Controllers\UtazasController;
use Illuminate\Support\Facades\Route;

Route::get('/', [UtazasController::class, 'welcome']);
Route::get('/utazas/{id}', [UtazasController::class, 'utazas']);
Route::get('/uticel/{uticel}', [UtazasController::class, 'uticel']);
