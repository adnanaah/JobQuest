import {Component, Input, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute, Router} from "@angular/router";
import {FormsModule} from "@angular/forms";
import {NgIf} from "@angular/common";
import {MyConfig} from "../../../MyConfig";
import {GlobalMessageService} from "../../../services/global-message.service";

@Component({
  selector: 'app-registration-verification',
  standalone: true,
  imports: [
    FormsModule,
    NgIf
  ],
  templateUrl: './registration-verification.component.html',
  styleUrl: './registration-verification.component.css'
})
export class RegistrationVerificationComponent implements OnInit{

  @Input() newUserAccountID: any | undefined;

  verificationRequest = {
    accountID: "",
    verificationCode: ""
  };

  constructor(
    private httpClient: HttpClient,
    public activatedRoute: ActivatedRoute,
    private router: Router,
    private globalMessageService : GlobalMessageService
  ){}

  ngOnInit(): void {
  }

  send(){
    this.verificationRequest.accountID = this.newUserAccountID;
    this.httpClient.post(MyConfig.adresa_servera + "/VerifikacijaEndpoint", this.verificationRequest).subscribe({
      next: (response: any) => {
        this.globalMessageService.setMessage('Verification successful!', 'success');
        this.router.navigate(['/edit-profile']);
      },
      error: (error) => {
        this.globalMessageService.setMessage(error.error, 'error');
        this.deleteUserAccount(this.newUserAccountID);
      }
    });
  }

  deleteUserAccount(ID:any){
    this.httpClient.post(MyConfig.adresa_servera + "/DeleteEndpoint", ID).subscribe({
      next: (response: any) => {
        console.log("Account successfully removed");
      },
      error: (error) => {
        console.log(error.error);
      }
    });
  }
  close(){
    this.deleteUserAccount(this.newUserAccountID);
    this.newUserAccountID = null;
  }
}
