import { Component, OnInit } from '@angular/core';
import { UserserviceService } from 'src/app/service/userservice.service';
import { User } from "src/app/interfaces/user";

@Component({
  selector: 'app-tableusers',
  templateUrl: './tableusers.component.html',
  styleUrls: ['./tableusers.component.css']
})
export class TableusersComponent implements OnInit {

  users: User[];

  constructor(private _userService: UserserviceService) {
  }

  public getUsers() {
    this._userService.getUsers()
    .subscribe(
      (response) => {
        this.users = response.usersList;
      }
    ); 
  }

  ngOnInit(): void {
    this.getUsers();
  }
}
