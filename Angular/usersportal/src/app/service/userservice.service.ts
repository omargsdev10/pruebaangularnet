import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { User } from '../interfaces/user';

@Injectable({
  providedIn: 'root'
})
export class UserserviceService {

  baseUrl: string = "https://localhost:7027/";
  
  getUsers(): Observable<any> {
    return this.http.get(this.baseUrl + "Users/GetUsers");
  }

  postUser(user : User) {
    this.http.post<User>(this.baseUrl + "Users/CreateUser", user);
  }

  constructor(private http: HttpClient) { }
}
