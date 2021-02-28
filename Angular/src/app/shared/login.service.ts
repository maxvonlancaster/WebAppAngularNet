import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  readonly rootUrl = 'http://localhost:50287/api';


  constructor() { }

  register() { }

  login() { }

  logout() { }
  
}
