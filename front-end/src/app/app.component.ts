import {Component, OnInit} from '@angular/core';
import {Router, RouterLink, RouterOutlet} from '@angular/router';
import {HttpClient, HttpClientModule} from "@angular/common/http";
import {MyConfig} from "./MyConfig";
import {MatSlideToggleModule} from "@angular/material/slide-toggle";
import {GlobalMessageComponent} from "./components/global-message/global-message.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    HttpClientModule,
    RouterLink,
    MatSlideToggleModule,
    GlobalMessageComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit{

  constructor(
    public router: Router,
    private httpClient: HttpClient,
  ) {
  }

  ngOnInit(): void {

  }

}
