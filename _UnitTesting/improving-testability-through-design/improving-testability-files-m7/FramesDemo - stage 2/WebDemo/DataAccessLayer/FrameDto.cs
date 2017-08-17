using System.Collections.Generic;

namespace WebDemo.DataAccessLayer
{
    public class FrameDto
    {

        private IList<CircleDto> circles = new List<CircleDto>();

        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public IList<CircleDto> Circles { get { return this.circles; } }
    
    }
}