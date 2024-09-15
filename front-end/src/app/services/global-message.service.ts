import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class GlobalMessageService {
  private messageSubject = new BehaviorSubject<string | null>(null);
  private messageTypeSubject = new BehaviorSubject<string>('');

  getMessage(): Observable<string | null> {
    return this.messageSubject.asObservable();
  }

  getMessageType(): Observable<string> {
    return this.messageTypeSubject.asObservable();
  }

  setMessage(message: string, type: 'success' | 'error'): void {
    this.messageSubject.next(message);
    this.messageTypeSubject.next(type);

    setTimeout(() => {
      this.clearMessage();
    }, 5000);
  }

  clearMessage(): void {
    this.messageSubject.next(null);
    this.messageTypeSubject.next('');
  }
}
