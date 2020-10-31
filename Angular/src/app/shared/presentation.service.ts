import { Injectable } from '@angular/core';
import { Presentation } from './presentation.model';

@Injectable({
  providedIn: 'root',
})
export class PresentationService {
  formData: Presentation;

  constructor() {}
}
