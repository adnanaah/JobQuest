import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from "@angular/router";
import {NgOptimizedImage} from "@angular/common";

@Component({
  standalone: true,
  imports: [
    NgOptimizedImage
  ],
  selector: 'app-homepage',
  templateUrl: './homepage.html',
  styleUrl: './homepage.css'
})
export class HomepageComponent implements OnInit{


  constructor(
    public activatedRoute: ActivatedRoute,
    private router: Router
    ){}

  ngOnInit(): void {
    }

  registerNavigate(){
    this.router.navigate(['/register'])
  }
}
