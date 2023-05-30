import { Component, OnInit } from '@angular/core';
import { UserserviceService } from 'src/app/service/userservice.service';
import { User } from "src/app/interfaces/user";
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-userform',
  templateUrl: './userform.component.html',
  styleUrls: ['./userform.component.css']
})
export class UserformComponent {
  checkoutForm = this.formBuilder.group({
    id: 0,
    name: '',
    lastName: '',
    mothersLastName: '',
    email: '',
    address: '',
    phoneNumber: ''
  });

  public postUser(user : User) {
    this._userserviceService.postUser(user);
  }
  user: User = {
    id: 0,
    name: "",
    lastName: "",
    mothersLastName: "",
    address: "",
    phoneNumber: "",
    email: ""
  };
    
  onSubmit(): void {
    console.log("this.checkoutForm");
    console.log(this.checkoutForm.value.id);
    this.user.id = this.checkoutForm.value.id ?? 0;
    this.user.name = this.checkoutForm.value.name ?? "";
    this.user.lastName = this.checkoutForm.value.lastName ?? "";
    this.user.mothersLastName = this.checkoutForm.value.mothersLastName ?? "";
    this.user.address = this.checkoutForm.value.address ?? "";
    this.user.phoneNumber = this.checkoutForm.value.phoneNumber ?? "";
    this.user.email = this.checkoutForm.value.email ?? "";
    this.postUser(this.user);
  }

  
  constructor(
    private formBuilder: FormBuilder,
    private _userserviceService: UserserviceService
  ){}
}
