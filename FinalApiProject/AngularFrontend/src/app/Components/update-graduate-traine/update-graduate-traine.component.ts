import { GraduateTraineeService } from 'src/app/graduate-trainee.service';
// update-graduate-traine.component.ts

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-update-graduate-traine',
  templateUrl: './update-graduate-traine.component.html',
  styleUrls: ['./update-graduate-traine.component.css']
})
export class UpdateGraduateTraineComponent implements OnInit {
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

  updateGraduateTrainee() {
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
  deleteGraduateTrainee() {
    this.graduateTraineeService.deleteGraduateTrainee(this.graduateTraineeId).subscribe({
      next: (response) => {
        console.log('Graduate trainee deleted successfully', response);
        this.router.navigate(['/dashboard']);
      },
      error: (error) => {
        console.error('Error deleting graduate trainee', error);
      }
    });
  }
}
