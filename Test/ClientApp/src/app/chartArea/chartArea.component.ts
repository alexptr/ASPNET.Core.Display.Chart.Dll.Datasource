import { Component, OnInit } from '@angular/core';
import { ChartService } from '../shared/services/chartData.service';

@Component({
  selector: 'app-chart',
  templateUrl: './chartArea.component.html',
  styleUrls: ['./chartArea.component.scss']
})
export class ChartAreaComponent implements OnInit {
    visible = true;
    data: any;

    constructor(private chartService: ChartService) { }

    ngOnInit() {
      this.chartService.getData().subscribe( chartData => {
          const name = chartData[0].name;
          const labels: string[] = chartData[0].points.map(item => item.date);
          const data: number[] = chartData[0].points.map(item => item.value);

          this.populateChartData(name, labels, data);
      });
    }

    toggleChart() {
        this.visible = !this.visible;
    }

    getChartData() {
        this.chartService.getData().subscribe(chartData => {
          const name = chartData[0].name;
          const labels: string[] = chartData[0].points.map(item => item.date);
          const data: number[] = chartData[0].points.map(item => item.value);

          this.populateChartData(name, labels, data);
        });
    }

    populateChartData(name: string, labels: string[], data: number[]): any {
        this.data = {
          labels: [...labels],
          datasets: [
              {
                  label: name,
                  data: [...data],
                  fill: false,
                  borderColor: '#8bc0c0'
              }
          ]
        };
    }


}
