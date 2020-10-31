import { Component, OnInit } from '@angular/core';
import { PresentationService } from 'src/app/shared/presentation.service';

@Component({
  selector: 'app-presentation',
  templateUrl: './presentation.component.html',
  styleUrls: ['./presentation.component.css'],
})
export class PresentationComponent implements OnInit {
  constructor(public service: PresentationService) {}

  ngOnInit(): void {}
}
