import {Component, OnInit} from '@angular/core';
import {GlobalMessageService} from "../../services/global-message.service";
import {NgClass, NgIf} from "@angular/common";

@Component({
  selector: 'app-global-message',
  standalone: true,
  imports: [
    NgClass,
    NgIf
  ],
  templateUrl: './global-message.component.html',
  styleUrl: './global-message.component.css'
})
export class GlobalMessageComponent implements OnInit {
  message: string | null = null;
  messageType: string = '';

  constructor(private globalMessageService: GlobalMessageService) {}

  ngOnInit(): void {
    // Subscribe to the message and type observables
    this.globalMessageService.getMessage().subscribe((msg) => {
      this.message = msg;
    });
    this.globalMessageService.getMessageType().subscribe((type) => {
      this.messageType = type;
    });
  }
}
