import { Component, OnInit } from '@angular/core';
import { PresentationService } from 'src/app/shared/presentation.service';

@Component({
  selector: 'app-presentation-list',
  templateUrl: './presentation-list.component.html',
  styleUrls: ['./presentation-list.component.css']
})
export class PresentationListComponent implements OnInit {

  constructor(public service: PresentationService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

}
