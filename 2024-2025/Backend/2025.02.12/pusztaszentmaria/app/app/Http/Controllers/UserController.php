<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Validation\Rules\Password;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Auth;
use App\Models\User;



class UserController extends Controller
{
    public function GetLoginPage(){
    
        return view('login');
    }

    public function LoginRoute(Request $req){
        $req -> validate([
            'email' => 'required|email',
            'password' => 'required'
        ], [
            'email.required' => 'Az email megadása kötelező!',
            'email.email' => 'Az email formátuma nem megfelelő!',

            'password.required' => 'A jelszó megadása kötelező!'
        ]);

        if(Auth::attempt(['email' => $req -> email, 'password' => $req -> password])){
            return redirect('/')->with('success', 'Sikeres bejelentkezés!');
        } else {
            return back() -> with('error', 'Hibás email vagy jelszó!');
        }
    }

    public function register(){
        return view('register');
    }

    public function RegisterRoute(Request $req){
        $req -> validate([
            'nev' => 'required|unique:user,nev',
            'email' => 'required|email',
            'password' => ['required', 'confirmed', Password::min(8) -> numbers() -> letters() -> mixedCase()],
            'password_confirmation' => 'required'
        ],[
            'nev.required' => 'A név megadása kötelező!',
            'nev.unique' => 'A név már foglalt!',

            'email.required' => 'Az email megadása kötelező!',
            'email.email' => 'Az email formátuma nem megfelelő!',

            'password.required' => 'A jelszó megadása kötelező!',
            'password.confirmed' => 'A jelszavak nem egyeznek!',
            'password.min' => 'A jelszó minimum 8 karakter hosszú legyen!',
            'password.numbers' => 'A jelszó tartalmazzon számot!',
            'password.letters' => 'A jelszó tartalmazzon kisbetűt!',
            'password.mixed' => 'A jelszó tartalmazzon nagybetűt!',

            'password_confirmation.required' => 'A jelszó megerősítése kötelező!'
        ]);

        $data = new User;

        $data -> nev = $req -> nev;
        $data -> email = $req -> email;
        $data -> password = Hash::make($req -> password);

        $data -> save();

        return redirect('/')->with('success', 'Sikeres regisztráció!');
    }
    
    public function LogoutRoute(){
        Auth::logout();
        return redirect('/')->with('success', 'Sikeres kijelentkezés!');
    }

    public function ProfileRoute(){
        if(Auth::check()){
            return view('profil');
        } else {
            return redirect('/')->with('error', 'Előbb jelentkezz be!');
        }
    }

    public function newPass(Request $req){
        $req -> validate([
            'old_password' => 'required',
            'password' => ['required', 'confirmed', Password::min(8) -> numbers() -> letters() -> mixedCase()],
            'password_confirmation' => 'required'
        ], [
            'old_password.required' => 'A régi jelszó megadása kötelező!',

            'password.required' => 'Az új jelszó megadása kötelező!',
            'password.confirmed' => 'Az új jelszavak nem egyeznek!',
            'password.min' => 'Az új jelszó minimum 8 karakter hosszú legyen!',
            'password.numbers' => 'Az új jelszó tartalmazzon számot!',
            'password.letters' => 'Az új jelszó tartalmazzon kisbetűt!',
            'password.mixed' => 'Az új jelszó tartalmazzon nagybetűt!',

            'password_confirmation.required' => 'Az új jelszó megerősítése kötelező!'
        ]);

        $user = Auth::user();

        if(Hash::check($req -> old_password, $user -> password)){
            $user -> password = Hash::make($req -> password);
            $user -> Save();

            return redirect('/profil')->with('success', 'Sikeres jelszóváltoztatás!');
        } else {
            return back() -> with('error', 'Hibás régi jelszó!');
        }
    }
}
