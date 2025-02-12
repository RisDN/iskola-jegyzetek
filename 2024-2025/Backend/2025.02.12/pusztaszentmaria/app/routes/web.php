<?php

use App\Http\Controllers\NewsController;
use App\Http\Controllers\GuestbookController;

use App\Http\Controllers\UserController;
use Illuminate\Support\Facades\Route;


Route::view('/', 'welcome');
Route::get('/news', [NewsController::class, 'news']);
Route::get('/guestbook', [GuestbookController::class, 'guestbook']);
Route::post('/guestbook', [GuestbookController::class, 'addGuestbook']);
Route::get('/register', [UserController::class, 'register']);
Route::post('/register', [UserController::class, 'RegisterRoute']);
Route::get('/login', [UserController::class, 'GetLoginPage']);
Route::post('/login', [UserController::class, 'LoginRoute']);
Route::get('/logout', [UserController::class, 'LogoutRoute']);
Route::get('/profil', [UserController::class, 'ProfileRoute']);
Route::post('/profil', [UserController::class, 'newPass']);



