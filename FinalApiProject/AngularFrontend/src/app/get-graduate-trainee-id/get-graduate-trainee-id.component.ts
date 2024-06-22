// get-graduate-trainee-id.component.ts

import { Component, OnInit } from '@angular/core';
import { GraduateTraineeService } from '../graduate-trainee.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-get-graduate-trainee-id',
  templateUrl: './get-graduate-trainee-id.component.html',
  styleUrls: ['./get-graduate-trainee-id.component.css'],
})
export class GetGraduateTraineeIdComponent implements OnInit {
  graduateTraineeId!: number;
  graduateTraineeData: any; // Update with your actual data structure

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private graduateTraineeService: GraduateTraineeService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      this.graduateTraineeId = params['id'];
      this.loadGraduateTraineeData();
      this.graduateTraineeService.getGraduateTraineeById(this.graduateTraineeId)
      .subscribe({
        next:(response)=>{
          this.graduateTraineeData=response;
        }
      })
    });
  }

  loadGraduateTraineeData() {
    // Use your service to fetch data based on graduateTraineeId
    this.graduateTraineeService.getGraduateTraineeById(this.graduateTraineeId).subscribe({
      next: (data) => {
        this.graduateTraineeData = data;
      },
      error: (error) => {
        console.error('Error fetching graduate trainee data', error);
      },
      complete: () => {
        // Optional: Add any logic that needs to be executed when the observable is complete
      }
    });

  }

  getGraduateTraineeById() {
    // Use your service to update graduate trainee data
    this.graduateTraineeService.updateTraineeDetails(this.graduateTraineeId, this.graduateTraineeData).subscribe({
      next: (response) => {
        console.log('Graduate trainee updated successfully', response);
        // Navigate back to the list after a successful update
        this.router.navigate(['/dashboard']); // Update with your desired route
      },
      error: (response1) => {
        console.error('Error updating graduate trainee', response1);
      }
    });

  }
}
