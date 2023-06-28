import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-manage-store',
  templateUrl: './manage-store.component.html',
  styleUrls: ['./manage-store.component.css']
})
export class ManageStoreComponent implements OnInit {

  form!: FormGroup;

  constructor() { }

  ngOnInit(): void {
    this.form = new FormGroup({
      categoryName: new FormControl('', [Validators.required]),
      categoryDescription: new FormControl('', Validators.required)
    });
  }

}
