using Models;
using Models.Common;
using WebDemo.DataAccessLayer;

namespace WebDemo.Gateway
{
    public class DataGateway
    {

        private DataAccess dal;

        public DataGateway(DataAccess dal)
        {

            if (dal == null)
                throw new System.ArgumentNullException("dal", "Error creating data gateway: Data access layer is null.");

            this.dal = dal;
        
        }

        public Frame LoadFrame()
        {
            FrameDto dto = dal.LoadFrame();
            return dto.ToFrame();
        }

    }

    public static class DtoConversionExtensions
    {
        
        public static Circle ToCircle(this CircleDto dto)
        {
            return new Circle(new Location(dto.X, dto.Y), dto.Radius);
        }

        public static Frame ToFrame(this FrameDto dto)
        {
            
            Frame frame = new Frame(new Size(dto.Length, dto.Width));
            
            foreach (CircleDto circleDto in dto.Circles)
                frame = frame.Add(circleDto.ToCircle());
            
            return frame;

        }

    }
}