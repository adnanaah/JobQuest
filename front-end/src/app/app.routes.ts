import { Routes } from '@angular/router';
import {HomepageComponent} from "./homepage/homepage";
import {RegistrationComponent} from "./components/registration/registration.component";
import {
  RegistrationVerificationComponent
} from "./components/registration/registration-verification/registration-verification.component";
import {EditProfileComponent} from "./components/edit-profile/edit-profile.component";

export const routes: Routes = [
  {path: '', component: HomepageComponent},
  {path: 'register', component: RegistrationComponent},
  {path: 'verification', component: RegistrationVerificationComponent},
  {path: 'edit-profile', component: EditProfileComponent},
];
