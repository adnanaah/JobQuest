import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";
import {HttpClient} from "@angular/common/http";
import {MyConfig} from "../../MyConfig";
import {NgForOf, NgIf} from "@angular/common";
import {FormBuilder, FormGroup, FormsModule, Validators} from "@angular/forms";
import { ReactiveFormsModule } from '@angular/forms';
import {MatRadioButton, MatRadioGroup, MatRadioModule} from '@angular/material/radio';
import {RegistrationVerificationComponent} from "./registration-verification/registration-verification.component";
import {GlobalMessageService} from "../../services/global-message.service";


@Component({
  selector: 'app-registration',
  standalone: true,
  imports: [
    NgForOf,
    FormsModule,
    MatRadioButton,
    MatRadioGroup,
    ReactiveFormsModule,
    NgIf,
    RegistrationVerificationComponent
  ],
  templateUrl: './registration.component.html',
  styleUrl: './registration.component.css'
})
export class RegistrationComponent implements OnInit{

  emailForm: FormGroup;
  newUserAccount = {
    username: "",
    password: "",
    ime: "",
    prezime: "",
    emailAddress: "",
    drzavaID: 0,
    isAplikant: false,
    isPoslodavac: false,
  };

  newUserAccountID:any = null;
  drzave: any;

  constructor(
    private httpClient: HttpClient,
    public activatedRoute: ActivatedRoute,
    private router: Router,
    private fb: FormBuilder,
    private globalMessageService : GlobalMessageService
  ){
    this.emailForm = this.fb.group({
      username: [this.newUserAccount.username, Validators.required],
      password: [this.newUserAccount.password, Validators.required],
      ime: [this.newUserAccount.ime, Validators.required],
      prezime: [this.newUserAccount.prezime, Validators.required],
      emailAddress: [this.newUserAccount.emailAddress, [Validators.required, Validators.email]],
      drzavaID: [this.newUserAccount.drzavaID, Validators.required],
      accountType: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    this.getAllDrzava();
  }

  onSubmit(){
    if (this.emailForm.valid) {
      this.newUserAccount = this.emailForm.value;
      console.log('Form Submitted', this.emailForm.value);
    } else {
      console.log('Invalid form');
    }

    if(this.emailForm.get('accountType')?.value=="freelancer"){
      this.newUserAccount.isAplikant = true;
      this.newUserAccount.isPoslodavac = false;
    }else if(this.emailForm.get('accountType')?.value=="employer"){
      this.newUserAccount.isPoslodavac = true;
      this.newUserAccount.isAplikant = false;
    }

    this.httpClient.post(MyConfig.adresa_servera + "/RegisterEndpoint", this.newUserAccount)
      .subscribe({
        next: (response: any) => {
          this.newUserAccountID = response;
          console.log('Account information saved.');
        },
        error: (error) => {
          this.globalMessageService.setMessage(error.error, 'error');
        }
      })
  }

  getAllDrzava(){
    this.httpClient.get(MyConfig.adresa_servera + "/DrzavaGetAllEndpoint").subscribe((x:any)=>{
      this.drzave = x.drzave;
    })
  }

}
